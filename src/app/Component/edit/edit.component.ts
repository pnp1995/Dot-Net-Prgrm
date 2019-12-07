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
  constructor(private Notes: NotesServiceService, public dialogRef: MatDialogRef<EditComponent>,
    @Inject(MAT_DIALOG_DATA) private data) { 
      this.onenote = this.data.notesData;
    }
    
  ngOnInit() {
  }
  onSubmit( title, description) {
    console.log('user data ', title, description,this.token.result)
    this.Notes.update(this.onenote.id, title, this.token.result, description).subscribe((data: any) => {
    });
  }
}

