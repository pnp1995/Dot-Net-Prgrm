import { Router } from '@angular/router';
import { NotesServiceService } from './../../Services/NotesServices/notes-service.service';
import { FormGroup, Validators, FormControl, NgForm } from '@angular/forms';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-notes',
  templateUrl: './notes.component.html',
  styleUrls: ['./notes.component.scss']
})
export class NotesComponent implements OnInit {
notes: FormGroup;
form: NgForm;
token = JSON.parse(localStorage.getItem('userData'));
note1 = true;
note2 = false;
  constructor(private note:NotesServiceService,private router:Router) { }
 
  ngOnInit() {
    this.notes = new FormGroup({
    title: new FormControl('',[Validators.required]),
    description: new FormControl('',[Validators.required])
    });
  }
  onClick(){
    this.note1 = false;
    this.note2 = true;
  }
  onSubmit() {
    console.log('under submit', this.notes.value);
    console.log(this.token.result);
    this.note.Postrequest(this.notes.value, this.token.result).subscribe(data=>{   
    });    

  }
}
