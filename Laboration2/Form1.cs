using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Laboration2
{
    public partial class MainForm : Form
    {
        // Properties to keep track of the current state of the application.
        public bool PreviouslySaved { get; set; }
        public string CurrentFileName { get; set; }
        public bool UnsavedChanges { get; set; }

        // MainForm: Constructur that initializes the application.
        // Pre: -
        // Post: Application has been initialized. The ability to use Drag And Drop
        // in the text area has been added.
        public MainForm()
        {
            InitializeComponent();
            mainTextBox.AllowDrop = true;
            mainTextBox.DragEnter += new DragEventHandler(MainTextBox_DragEnter);
            mainTextBox.DragDrop += new DragEventHandler(MainTextBox_DragDrop);
        }

        // MainTextBox_DragEnter: Eventhandler for when the user drags a file over the 
        // text area. Visual aid allows the user to see if the filetype is supported or not.
        // Pre: - 
        // Post: If the file was a .txt-file, the DragDrop-event has been fired. 
        void MainTextBox_DragEnter(object sender, DragEventArgs e)
        {
            string[] filenames = (string[]) e.Data.GetData(DataFormats.FileDrop);
            string filetype = Path.GetExtension(filenames[0]);
            if (filetype == ".txt")
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        // MainTextBox_DragDrop: Eventhandler for when the user drops a .txt-file over the text area.
        // Depending on the if either CTRL, SHIFT or neither is pressed during the operation, it'll have
        // different outcomes.
        // Pre: The dropped files is a .txt-file.
        // Post: There are three possible paths.
        // - If the user pressed CTRL while dropping the file, the files content is added to the end of
        // currently open document.
        // - If the user pressed SHIFT while dropping the file, the files content is added at the position
        // where the file was dropped.
        // - If the user pressed neither CTRL nor shift, the dropped file will be loaded. If there were unsaved
        // changes, the user where asked whether or not to save these first. Once loaded, PreviouslySaved is set
        // to true, CurrentFileName is set to equal the dropped file's filename, UnsavedChanges set to false
        // and the forms title changed to the opened documents filename.
        void MainTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] filenames = (string[]) e.Data.GetData(DataFormats.FileDrop);
            string fileToLoad = filenames[0];
            string textFromFile;
            using (StreamReader streamReader = new StreamReader(fileToLoad))
                textFromFile = streamReader.ReadToEnd();
            if ((e.KeyState & 8) == 8) // CTRL-key pressed.
                mainTextBox.Text += textFromFile;
            else if ((e.KeyState & 4) == 4) // Shift-key pressed.
            {
                int inputIndex = mainTextBox.SelectionStart;
                string textBeforeDroppedText = mainTextBox.Text.Substring(0, inputIndex);
                string textAfterDroppedText = mainTextBox.Text.Substring(inputIndex);
                mainTextBox.Text = textBeforeDroppedText + textFromFile + textAfterDroppedText;
            }
            else // Neither CTRL nor SHIFT pressed.
            {
                if (UnsavedChanges)
                    if (!AskToSaveChanges())
                        return;
                mainTextBox.Text = textFromFile;
                PreviouslySaved = true;
                CurrentFileName = fileToLoad;
                UnsavedChanges = false;
                this.Text = Path.GetFileName(fileToLoad);
            }
        }

        // NewMenuItem_Click: The application is reset with an empty textbox.
        // Pre: -
        // Post: The application has been reset. If there were unsaved changes,
        // the user where asked whether or not to save these first.
        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            if (UnsavedChanges)
                if (!AskToSaveChanges())
                    return;
            mainTextBox.Clear();
            this.Text = "dok1.txt";
            PreviouslySaved = false;
            CurrentFileName = null;
            UnsavedChanges = false;
        }

        // MainForm_FormClosing: Eventhandler for when the application is about to be closed down
        // by means other than pushing the close button. This allows the user the chance to save 
        // their unsaved changed before the application is closed.
        // Pre: -
        // Post: If there were unsaved changed, the user has had the chance to save those before the
        // application is closed.
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UnsavedChanges)
                if (!AskToSaveChanges())
                    e.Cancel = true;
        }

        // AskToSaveChanges: Asks the user if they'd like to save their unsaved changes.
        // Pre: There are unsaved changes.
        // Post: Dependant on the users choice, on of three things have happened.
        // - If the user clicked Cancel, the function ends and returns false.
        // - If the user clicked Yes, they're allowed to save their changes and then the function returns true.
        // - If the user clicked No, the function ends yet return true as the user still made a decision.
        private bool AskToSaveChanges()
        {
            DialogResult dialogResult = MessageBox.Show("Du har osparade ändringar. Vill du spara dem först?", "Varning",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Cancel)
                return false;
            if (dialogResult == DialogResult.Yes)
                saveMenuItem.PerformClick();
            return true;
        }

        // ExitMenuItem_Click: Closes the application. The user will be prompted so save any unsaved changes before
        // this happens.
        // Pre: -
        // Post: If there were unsaved changes, the user has had the chance to save those before the
        // application is closed.
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            if (UnsavedChanges)
                if (!AskToSaveChanges())
                    return;
            Application.Exit();
        }

        // OpenMenuItem_Click: Opens a new document. The user will be prompted to save any unsaved changes before this happens.
        // Pre: -
        // Post: If there were unsaved changes, the user has had the chance to save those. Then, the chosen document has been opened.
        // CurrentFileName contains the location of the newly opened document, PrevioslySaved has been set to true and UnsavedChanges
        // have been set to false. The forms title has been set to the opened documents name.
        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            if (UnsavedChanges)
                if (!AskToSaveChanges())
                    return;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Textdokument (.txt)|*.txt",
                Title = "Öppna..."
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                    mainTextBox.Text = streamReader.ReadToEnd();
                PreviouslySaved = true;
                CurrentFileName = openFileDialog.FileName;
                UnsavedChanges = false;
                this.Text = Path.GetFileName(CurrentFileName);
            }
        }

        // SaveMenuItem_Click: Saves the current document. If it has been saved prior, it's saved in the same file. Otherwice,
        // the user will be prompted to define its name and location.
        // Pre: -
        // Post: The document has been saved, either to its previous location, or if it's a new file, to a user specified location.
        // UnsavedChanges has been set to false and the forms title have been updated to indicate this.
        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if (PreviouslySaved)
            {
                using (StreamWriter streamWriter = new StreamWriter(CurrentFileName))
                    streamWriter.Write(mainTextBox.Text);
                UnsavedChanges = false;
                this.Text = Path.GetFileName(CurrentFileName);
            }
            else
                saveAsMenuItem.PerformClick();
        }

        // SaveAsMenuItem_Click: Saves the current document under a new filename.
        // Pre: -
        // Post: The document has been saved to a user specified location. CurrentFileName has been set to the specified location,
        // PreviosulySaved set to true, UnsavedChanges set to false and the forms title have been updated to the specified filename.
        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Textdokument (.txt)|*.txt",
                Title = "Spara fil..."
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                    streamWriter.Write(mainTextBox.Text);
                PreviouslySaved = true;
                CurrentFileName = saveFileDialog.FileName;
                UnsavedChanges = false;
                this.Text = Path.GetFileName(CurrentFileName);
            }
        }

        // MainTextBoxChanged: Whenever the text of the textarea is changed, the application will
        // indicate that changes have been made by adding a '*' to the forms title. Additionally,
        // the information on the bottom of the screen containing details of the document is also updated.
        // Pre: -
        // Post: The property UnsavedChanges has been set to true. If this was the first change, the title of the
        // form has been appended by a '*' to give visual aid to the user, letting them know that there are unsaved
        // changes. Additionally, the information regarding the document displayed on the bottom labels has been
        // updated according to the current content.
        private void MainTextBoxChanged(object sender, EventArgs e)
        {
            if (!UnsavedChanges)
                this.Text += "*";
            UnsavedChanges = true;
            UpdateInformationLabels();
        }

        // UpdateInformationLabels: Sets the labels with information about the document according to its current content.
        // Pre: -
        // Post: The labels for number of letters (with and without spaces), words and rows have been updated based on the
        // content of the text area.
        private void UpdateInformationLabels()
        {
            numberOfLettersWithSpaceLabel.Text = "Bokstäver (inkl. mellanslag): " + NumberOfLettersInclSpaces(mainTextBox.Text);
            numberOfLettersWithoutSpaceLabel.Text = "Bokstäver (ex. mellanslag): " + NumberOfLettersExSpaces(mainTextBox.Text);
            numberOfWordsLabel.Text = "Ord: " + NumberOfWords(mainTextBox.Text);
            numberOfRowsLabel.Text = "Rader: " + NumberOfRows(mainTextBox.Text);
        }

        // NumberOfLettersInclSpaces: Counts the number of letters, including spaces, in the text input.
        // Pre: The text input is not null.
        // Post: The number of letters in the text input, including spaces, has been returned. 
        private int NumberOfLettersInclSpaces(string text)
        {
            char[] delimiters = new char[] { '\r', '\n' };
            string[] splitByDelimiters = text.Split(delimiters);
            string rejoinedString = string.Join("", splitByDelimiters);
            return rejoinedString.Length;
        }

        // NumberOfLettersExSpaces: Counts the number of letters, excluding spaces, in the text input.
        // Pre: The text input is not null.
        // Post: The number of letters in the text input, excluding spaces, has been returned. 
        private int NumberOfLettersExSpaces(string text)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            string[] splitByDelimiters = text.Split(delimiters);
            string rejoinedString = string.Join("", splitByDelimiters);
            return rejoinedString.Length;
        }

        // NumberOfWords: Counts the number of words in the text input.
        // Pre: The text input is not null.
        // Post: The number of words in the text input has been returned. 
        private int NumberOfWords(string text)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            return text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        // NumberOfWords: Counts the number of rows in the text input.
        // Pre: The text input is not null.
        // Post: The number of rows in the text input has been returned. 
        private int NumberOfRows(string text)
        {
            return text.Count(c => c.Equals('\n')) + 1;
        }

        // UndoMenuItem_Click: Applies the standard Undo-action.
        // Pre: A prior action has been made.
        // Post: Undoes the most recent action.
        private void UndoMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Undo();
        }

        // CutMenuItem_Click: Cuts the currently selected text to the clipboard.
        // Pre: There's an active selection.
        // Post: The selected text has been cut to the clipboard.
        private void CutMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Cut();
        }

        // CopyMenuItem_Click: Copies the currently selected text to the clipboard.
        // Pre: There's an active selection.
        // Post: The selected text has been copied to the clipboard.
        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Copy();
        }

        // PasteMenuItem_Click: Pastes the content of the clipboard to the markers position.
        // Pre: There's text content in the clipboard.
        // Post: The selected text has pasted into the document at the markers position.
        private void PasteMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Paste();
        }

        // SelectAllMenuItem_Click: Selects the entire content of the currently opened document.
        // Pre: -
        // Post: The entire content of the currently opened document has been selected.
        private void SelectAllMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectAll();
        }
    }
}
