import { DataService } from './../../Services/Data/data.service';
import { LabelComponent } from './../label/label.component';
import { Component, OnInit, Inject } from '@angular/core';
import { Router } from '@angular/router';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { LabelService } from 'src/app/Services/Label/label.service';
import { UserService } from 'src/app/Services/UserServices/user.service';
import { Title } from '@angular/platform-browser';

export interface DialogData {
  label: string;
  name: string;
}

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
  //label: string;
  list = true;
  email: string;
  label: string;
  userdata = JSON.parse(localStorage.getItem('userdata'));
  token = JSON.parse(localStorage.getItem('token'));
  popup = false;
  popup1 = true;
  data: any;
  view: boolean = true;
  profile = true;
  profileimage: File;
  photo = localStorage.getItem('imageUrl');
  userName = localStorage.getItem('username');
  userEmail = localStorage.getItem('useremail');
  constructor(public dialog: MatDialog, private labelservice: LabelService, private dataservice: DataService,
    private userService: UserService) { }

  ngOnInit() {
    this.labelservice.GetRequest(this.token.result).subscribe((response: any) => {
      this.label = response;
      console.log('label', this.label);
      this.list = true;
    });
    this.profiles()
  }

  openLabel(): void {
    const dialogRef = this.dialog.open(LabelComponent, {
      width: '250px',
      data: { label: this.label, email: this.email }
    });
  }
  // dialogRef.afterClosed().subscribe((result:any) => {
  //  console.log('The label was closed');
  //   this.label = result;
  // });
  changeView() {
    this.view = !this.view;
    this.dataservice.changeMessages(this.view);
  }
  onclick() {
    this.profile = false;
  }

  onFileChanged($event) {
    // const file = event.target.files[0];
    console.log($event);
    this.profileimage = <File>$event.target.files[0];
    console.log(this.profileimage);

    this.profiles();
  }
  profiles() {
    const formData = new FormData();
    formData.append('file', this.profileimage);
    console.log("profile", formData)
    this.userService.getProfilepic(this.token.result, formData).subscribe((data: any) => {
      console.log(data); 
      var url = data.result.result.profilePicUpload;
      console.log('url',data);
      var userName = data.result.result.firstName + " " + data.result.result.lastName;
        console.log('usser..>',userName);  
       var userEmail = data.result.result.emailid;
       console.log('emaail',userEmail);
       
      localStorage.setItem('imageUrl', url);
      localStorage.setItem('username', userName);
      localStorage.setItem('useremail', userEmail);
    });   
  }
  search(){
   this.userService.Search(this.token.result,Title).subscribe((data:any) =>{
    console.log (data);
   });
  }
  signout() {
    localStorage.clear();
  }

}

