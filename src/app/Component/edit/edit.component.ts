import { NotesServiceService } from './../../Services/NotesServices/notes-service.service';
import { Component, OnInit, Inject } from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.scss']
})
export class EditComponent implements OnInit {
  token = JSON.parse(localStorage.getItem('userData'));
  onenote;
  title:string;
  description:string;

  constructor(private Notes: NotesServiceService, public dialogRef: MatDialogRef<EditComponent>,
    @Inject(MAT_DIALOG_DATA) private data) { 
      this.onenote = this.data.notesData;
      console.log("one note---->",this.onenote);
      this.title = this.onenote.title;
      this.description = this.onenote.descriiption;
      console.log("title & des-->",this.title, " ", this.description);      
    }
    
  ngOnInit() {
  }
  onSubmit() {
    console.log("title & des-->",this.title, " ", this.description);
    const body = {
      "Id": this.onenote.id,
      "Title": this.title,
      "Descriiption": this.description
    }
    this.Notes.update(body).subscribe((data: any) => {
      console.log("res in edit note-->",data)
    });
  }
}

