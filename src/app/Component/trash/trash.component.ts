import { Component, OnInit, Input } from '@angular/core';
import { NotesServiceService } from 'src/app/Services/NotesServices/notes-service.service';

@Component({
  selector: 'app-trash',
  templateUrl: './trash.component.html',
  styleUrls: ['./trash.component.scss']
})
export class TrashComponent implements OnInit {
  token = JSON.parse(localStorage.getItem('token'));
  trashNotes = [];
  userdata = JSON.parse(localStorage.getItem('userdata'));
  @Input() trash:false;
  constructor( private Notes: NotesServiceService,) { }

  ngOnInit() {
  this.getTrashNotes();
  }
  getTrashNotes() {
    this.Notes.GetAllTrash(this.token.result).subscribe((status: any) => {
      this.trashNotes = status;
      console.log(this.trashNotes);   
    });
  }
}
