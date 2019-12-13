import { Component, OnInit } from '@angular/core';
import { NotesServiceService } from 'src/app/Services/NotesServices/notes-service.service';

@Component({
  selector: 'app-archive',
  templateUrl: './archive.component.html',
  styleUrls: ['./archive.component.scss']
})
export class ArchiveComponent implements OnInit {
  token = JSON.parse(localStorage.getItem('token'));
  archiveNotes = [];
  userdata = JSON.parse(localStorage.getItem('userdata'));
  constructor(private Notes: NotesServiceService, ) { }

  ngOnInit() {
    this.getAllArchive();
  }
  getAllArchive() {
    this.Notes.GetAllArchive(this.token.result).subscribe((status: any) => {
      this.archiveNotes = status;
      console.log(this.archiveNotes);
      
    });
  }
}
