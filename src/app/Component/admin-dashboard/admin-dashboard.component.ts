import { AdminService } from './../../Services/Admin/admin.service';
import { Component, OnInit, ViewChild } from '@angular/core';
import { DataSource } from '@angular/cdk/collections';
import { MatTable, MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material';
@Component({
  selector: 'app-admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.scss']
})
export class AdminDashboardComponent implements OnInit {
  dataSource;
  listData;  
  user = true;
  list = [];
  userlist= [];
  displayColumn: string[] = ['firstName', 'lastName', 'emailid', 'cardType','totalNotes','status'];
  displayColumns: string[] = ['id', 'email', 'loginTime', 'cardType'];
  @ViewChild(MatPaginator) paginator: MatPaginator;
  constructor(private admin: AdminService) { }

  ngOnInit() {
  this.UserDetailList();
  }
  getUserList() {
    this.admin.userList().subscribe((data: any) => {    
      this.list = data.result;        
      this.dataSource= this.list;
      console.log("sdgfhgsd",this.dataSource)
      this.dataSource = new MatTableDataSource(this.list);
      this.dataSource.paginator = this.paginator;
    }
    )}
  getList() {
  this.admin.userLogin().subscribe((data:any) => {
    this.userlist = data.result;
    console.log("logindetal-->",this.userlist);
    this.dataSource = this.userlist;
    this.dataSource = new MatTableDataSource(this.userlist);
    this.dataSource.paginator = this.paginator;
  })
  }
  UserDetailList() {
    this.user = false;
    this.getUserList();
  }
  UserLoginDetailList() {
    this.user = true;
    this.getList();
  }

}
