import { LabelService } from './../../Services/Label/label.service';
import { Component, OnInit, Inject } from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { DialogData } from '../dashboard/dashboard.component';


@Component({
  selector: 'app-label',
  templateUrl: './label.component.html',
  styleUrls: ['./label.component.scss']
})
export class LabelComponent implements OnInit {
  token = JSON.parse(localStorage.getItem('token'));
  userdata = JSON.parse(localStorage.getItem('userData'));
  label: string;
  displaylabel: any;
  constructor(private labelservice: LabelService,
    public dialogRef: MatDialogRef<LabelComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData) { }

  ngOnInit() {
    console.log(this.token.value);
    this.labelservice.GetRequest(this.token.result).subscribe((data: any) => {
      this.displaylabel = data;
      console.log("list", this.displaylabel);
    });
  }
  onNoClick(): void { 
    this.dialogRef.close(); 
  }
  addLabel() {
    console.log(this.token.result);
    this.labelservice.createLabel(this.label, this.token.result).subscribe((response: any) => { });
  }
  // deleteLabel(id){
  // this.labelservice.deleteLabel(id).subscribe(( data:any) => {});
  // }
}
