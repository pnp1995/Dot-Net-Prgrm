import { DataService } from './../../Services/Data/data.service';
import { CollaboratorComponent } from './../collaborator/collaborator.component';
import { EditComponent } from './../edit/edit.component';
import { NotesComponent } from './../notes/notes.component';
import { Router } from '@angular/router';
import { NotesServiceService } from './../../Services/NotesServices/notes-service.service';
import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { MatDialog } from '@angular/material';
@Component({
  selector: 'app-notes-display',
  templateUrl: './notes-display.component.html',
  styleUrls: ['./notes-display.component.scss']
})
export class NotesDisplayComponent implements OnInit {
  token = JSON.parse(localStorage.getItem('token'));
  title: string;
  descriiption: string;
  date: string;
  dialog: any;
  display;
  image;
  photo = localStorage.getItem('imageUrl');
  @Input() trash:false;
  @Input() notes: any[];
  @Output() event = new EventEmitter();
  colorpalette: any[] = [
    { ColorName: 'default', colorcode: "#FDFEFE" },
    { ColorName: 'Gold', colorcode: "#FFD700" },
    { ColorName: 'HotPink ', colorcode: "#FF69B4" },
    { ColorName: 'LimeGreen', colorcode: "#32CD32"},
    { ColorName: 'Olive', colorcode: "#808000" },
    { ColorName: 'Salmon', colorcode: "#FA8072" },
    { ColorName: 'Turquoise', colorcode: "#40E0D0" },
    { ColorName: 'Thistle', colorcode: "#D8BFD8" },
    { ColorName: 'Teal', colorcode: "#008080" },
    { ColorName: 'Plum ', colorcode: "#DDA0DD" },
    { ColorName: 'SkyBlue', colorcode: "#87CEEB" },
    { Colorname: 'SlateGray', colorcode: "#708090" }
  ];
  view = 'row rap';
  flag = true;


  constructor(private route: Router, private Notes: NotesServiceService, public dia: MatDialog,
    private dataservice: DataService) { }

  ngOnInit() {
    this.dataservice.currentMessages.subscribe(data => {

      this.view = data ? 'row wrap' : 'column';
      this.flag = data;
      console.log(this.notes);
      
    });
  }
  onLater(id)
  {
    var d=new Date();
    d.setHours(8,0,0);
    this.Notes.putrequest(id,d.toString()).subscribe( response => {
      console.log('dataa from back end',response);
      this.event.emit([]);
    })
  }
  onTommorow(id)
  {
    var d=new Date();
    d.setDate(d.getDate()+1);
    d.setHours(8,0,0);
    this.Notes.putrequest(id,d.toString()).subscribe( response => {
      console.log('dataa from back end',response);
      this.event.emit([]);
    })
  }
  onNext(id)
  {
    var d=new Date();
    d.setDate(d.getDate()+7);
    d.setHours(8,0,0);
    this.Notes.putrequest(id,d.toString()).subscribe( response => {
      console.log('dataa from back end',response);
      this.event.emit([]);
    })
  }

  setReminder(id) {
    console.log('set reminde', this.date);
    this.Notes.putrequest(id, this.date).subscribe((data: any) => {
      this.Notes = data;
      this.event.emit([]);
    })
  };
  onArchive(id, token) {
    console.log(id, this.token);
    this.Notes.GetArchive(id).subscribe((data: any) => {
      this.Notes = data;
      this.event.emit([]);
      console.log(data);

    });
  }
  unarchive(id) {
    console.log(id, this.token);
    this.Notes.UnArchive(id).subscribe((data: any) => {
      this.Notes = data;
      this.event.emit([]);
    });
  }
  Addcolor(note,colorcode:string) {
    console.log('under color', note.id);
    console.log('under color', colorcode);
    this.Notes.Getcolor( note.id, colorcode,this.token.result).subscribe((data: any) => {
      this.Notes = data;
      console.log("color>.>>",data);
      
      this.event.emit([]);
    });
  }
  DeleteNote(id) {
    console.log(id, this.token)
    this.Notes.addTrash(id).subscribe((data: any) => {
      this.Notes = data;
      this.event.emit([]);
      console.log(data);
      
    });
  }
  restore(id) {
    console.log("id" ,id);
    this.Notes.restore(id).subscribe((data: any) => {
      this.Notes = data;
      this.event.emit([]);
    });
  }
  restoreAll(token) {
   this.Notes.restoreAll(this.token.result).subscribe((data : any) => {
     this.Notes = data;
     this.event.emit([]);
  })
  }

  openDialog(note: any) {
    const dialogRef = this.dia.open(EditComponent, {
      data: { notesData: note }
    })
  }

  openCollaborater(note: any) {
    console.log("collaborator note", note);
    const dialogRef = this.dia.open(CollaboratorComponent, {
      data: note
    })
  }
  
  onFileChanged(event, id) {
    this.image = <File>event.target.files[0];
    this.addImage(id);
  }
  addImage(id){
    const formData = new FormData();
    formData.append('file', this.image);
    this.Notes.getImage(id, formData).subscribe((status: any) => {
      console.log(' resultttt---->', status);
    });
  }

  pinnote(id)
  { 
    this.Notes.pinNote(id).subscribe(data =>{
    },err =>{
      console.log(err);
    })
  }

  unpinnote(id)
  {
    this.Notes.unPinNote(id).subscribe(data =>{
      console.log(data);
    },err =>{
      console.log(err);
    })
  }
}
