import { AdminService } from './../../Services/Admin/admin.service';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin-login',
  templateUrl: './admin-login.component.html',
  styleUrls: ['./admin-login.component.scss']
})
export class AdminLoginComponent implements OnInit {
  login: FormGroup;

  constructor(private admin : AdminService , private router: Router) { }

  ngOnInit() {
    this.login = new FormGroup({
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{6,15}')]),
    });
  }
  onlogin(){
    console.log('under submit', this.login.value);
    this.admin.adminLogin(this.login.value).subscribe( (data:any) => {
      console.log("res in login-->",data);    
      this.router.navigate(['/admindash']);
    });

  }

}
