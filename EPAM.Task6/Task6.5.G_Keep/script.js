var sm = new StorageManager();

var modal = document.getElementById("modal");

var addNote = document.querySelector(".add-button");
var saveNote = document.querySelector(".save-button");
var closeNote = document.querySelector(".close-button");


function addNoteFunc() {
    var inputHeader = document.getElementById('note-header-input').value;
    var inputMessage = document.getElementById('note-text-textarea').value;
    var noteID = sm.addItem({ name: inputHeader, description: inputMessage });

    var notesList = document.getElementById('notes');

    var note = document.createElement('div');
    note.className = 'note';

    note.id = noteID;

    var noteHeader = document.createElement('div');
    noteHeader.className = "note-header";
    noteHeader.innerHTML = inputHeader;

    var noteMessage = document.createElement('div');
    noteMessage.className = "note-message";
    noteMessage.innerHTML = inputMessage;

    note.appendChild(noteHeader);
    note.appendChild(noteMessage);

    notesList.insertBefore(note, notesList.firstChild);

    modal.style.display = "none";
    document.getElementById("add-header").value = "";
    document.getElementById("add-msg").value = "";
}

