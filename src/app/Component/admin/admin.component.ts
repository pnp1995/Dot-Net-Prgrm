import { AdminService } from './../../Services/Admin/admin.service';
import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormControl, NgForm } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.scss']
})
export class AdminComponent implements OnInit {
  register: FormGroup;
  registerForm: any;
  form: NgForm;
  constructor(private router: Router,private admin : AdminService) { }

  ngOnInit() {
    this.register = new FormGroup({
      firstName: new FormControl('', [Validators.pattern('^[a-zA-Z]{4,15}'), Validators.required]),
      lastName: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{4,15}')]),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{6,15}')]),
    });
  }
  onlogin(){
    this.router.navigate(['login'])
  }
  onSubmit(){
    {
      console.log('under submit', this.register.value);
      this.admin.addAdmin(this.register.value).subscribe((data: any) => {
        console.log(data.result);
      });
    }
  }

}
