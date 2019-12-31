import { UserService } from 'src/app/Services/UserServices/user.service';
import { CollaboratorService } from './../../Services/Collaborator/collaborator.service';
import { Component, OnInit, Inject,EventEmitter,Output  } from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { AuthService } from 'angular-6-social-login';

@Component({
  selector: 'app-collaborator',
  templateUrl: './collaborator.component.html',
  styleUrls: ['./collaborator.component.scss']
})
export class CollaboratorComponent implements OnInit {
  token = JSON.parse(localStorage.getItem('token'));
  onenote: any = [];
  collabList: any = [];
  userEmail: string;
  userName: string;
  item = [];
  addemail: string;
  userdata = JSON.parse(localStorage.getItem('userData'));
  count : any;

  constructor(private collaborator: CollaboratorService,
    private userService: UserService,
    private auth: AuthService,
    private router: Router,
    public collaboratordialogRef: MatDialogRef<CollaboratorComponent>,
    @Inject(MAT_DIALOG_DATA) private data) {
    this.onenote = data;
  }

  ngOnInit() {
    console.log(this.token.value);
    this.userDetails();
    this.getList();
  }
  getList() {
    this.collaborator.getCollaborator(this.onenote.id).subscribe(response => {
      console.log("res in get list collab-->", response);
      this.collabList = response;
      var count = this.collabList.length;
      localStorage.setItem('countcollab',count);
     console.log( "colaabnumber>....***", count);  

    }, error => {
      console.log("error in get collab list", error);
    });
  }

  /**
   * this methood is to get login user (owner) details
   */
  userDetails() {
    try {
      this.userService.get(this.token.result).subscribe((data: any) => {
        console.log("data-->", data);
        this.userName = data.firstName + " " + data.lastName;
        this.userEmail = data.emailid;
        console.log("user details-->", this.userName, this.userEmail);
      });
    } catch (err) {
      console.log(err)
    }
  }

  sendData() {
    this.collaborator.addCollab(this.addemail, this.onenote.id, this.addemail).subscribe((data: any) => {
      console.log("res in collab-->", data);

    });
  }

  closeCollaborater() {
    this.collaboratordialogRef.close();
  }


  deleteCollaboratot(id) {
    console.log("user id-->", id)
    this.collaborator.removeCollaborator(id).subscribe((data: any) => {
      this.collaboratordialogRef.close();
      console.log("res in remove collab-->", data);
    }, error => {
      console.log("error", error);
    });
  }
}
