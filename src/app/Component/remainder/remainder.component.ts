import { NotesServiceService } from 'src/app/Services/NotesServices/notes-service.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-remainder',
  templateUrl: './remainder.component.html',
  styleUrls: ['./remainder.component.scss']
})
export class RemainderComponent implements OnInit {
  Notes = [];
  userData = JSON.parse(localStorage.getItem('userData'));
  constructor() { }

 
  ngOnInit() {
    // this.Notes.putrequest(this.userData.email).subscribe((data: any) => {
    //   this.Notes = data;
    // });
  }


}
