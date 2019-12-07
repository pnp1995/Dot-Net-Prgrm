import { Component, OnInit } from '@angular/core';
import { NotesServiceService } from 'src/app/Services/NotesServices/notes-service.service';

@Component({
  selector: 'app-get-notes',
  templateUrl: './get-notes.component.html',
  styleUrls: ['./get-notes.component.scss']
})
export class GetNotesComponent implements OnInit {
  token = JSON.parse(localStorage.getItem('token'));
  displayNotes = [];
  constructor(private note: NotesServiceService) { }

  ngOnInit() {
    console.log(this.token.value);
    this.note.GetRequest(this.token.result).subscribe((data: any) => {
      this.displayNotes = data;
      console.log("list", this.displayNotes);
    });
  }

}
