import { NotesComponent } from './../notes/notes.component';
import { Router } from '@angular/router';
import { NotesServiceService } from './../../Services/NotesServices/notes-service.service';
import { Component, OnInit, Input } from '@angular/core';
import { Console } from '@angular/core/src/console';
import { Subscriber } from 'rxjs';

@Component({
  selector: 'app-notes-display',
  templateUrl: './notes-display.component.html',
  styleUrls: ['./notes-display.component.scss']
})
export class NotesDisplayComponent implements OnInit {
  token = JSON.parse(localStorage.getItem('userData'));
  title: string;
  descriiption: string;
  date: string;
  Colour:any;
  @Input() notes: any[];
  colorpalette = [
    { ColorName: 'default', colorcode: '#FDFEFE'},
    { ColorName: 'Gold', colorcode: '#FFD700'},
    { ColorName: 'HotPink ', colorcode: '#FF69B4'},
    { ColorName: 'LimeGreen', colorcode:'#32CD32'},
    { ColorName: 'Olive', colorcode: '#808000' },
    { ColorName: 'Salmon', colorcode: '#FA8072' },
    { ColorName: 'Turquoise', colorcode: '#40E0D0'},
    { ColorName: 'Thistle', colorcode: '#D8BFD8' },
    { ColorName: 'Teal', colorcode: '#008080' },
    { ColorName: 'Plum ', colorcode: '#DDA0DD' },
    { ColorName: 'SkyBlue', colorcode: '#87CEEB' },
    { Colorname: 'SlateGray', colorcode: '#708090'}
  ];

  constructor(private route: Router, private Notes: NotesServiceService) { }

  ngOnInit() {
  }
  onAdd(id) {
    console.log('under add', this.token);
    this.Notes.putrequest(id, this.date, this.token).subscribe((data: any) => { }
    )
  };
  onArchive(id) {
    console.log(id, this.token)
    this.Notes.GetArchive(id).subscribe((data: any) => {
      this.Notes = data;
    });
  }
  Addcolor(id, name){
    console.log('under add',name);
    this.Notes.Getcolor(id,name).subscribe((data:any) => {
    this.Notes = data; 
    });
  }
  DeleteNote(id){
    console.log(id, this.token)
    this.Notes.addTrash(id).subscribe((data:any) =>{
      this.Notes = data;
    });
  }

}




