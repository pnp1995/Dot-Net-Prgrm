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
  token = JSON.parse(localStorage.getItem('token'));
  note1 = true;
  note2 = false;
  constructor(private Notes: NotesServiceService, private router: Router) { }

  ngOnInit() {
    this.notes = new FormGroup({
      title: new FormControl('', [Validators.required]),
      description: new FormControl('', [Validators.required])
    });
  }
  onClick() {
    this.note1 = false;
    this.note2 = true;
  }
  onSubmit() {
    const data = {
      "Title": this.notes.controls.title.value,
      "Descriiption": this.notes.controls.description.value
    }
    console.log('under submit', data);
    console.log(this.token.result);
    this.Notes.Postrequest(data, this.token.result).subscribe(status => {
    console.log('data ..', status);

    });

  }
}
