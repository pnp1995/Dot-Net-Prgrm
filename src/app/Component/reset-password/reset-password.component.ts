import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/Services/UserServices/user.service';
import { FormGroup, Validators, FormControl, NgForm, RequiredValidator, FormControlName } from '@angular/forms';

@Component({
  selector: 'app-reset-password',
  templateUrl: './reset-password.component.html',
  styleUrls: ['./reset-password.component.scss']
})
export class ResetPasswordComponent implements OnInit {
  reset: FormGroup;
  form:NgForm;
  constructor(private userService:UserService) { }

  ngOnInit() {
    this.reset = new FormGroup({
      email: new FormControl('',[Validators.required,Validators.email]),
      password: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{6,15}')]),
      confirmPassword: new FormControl('',[Validators.required,Validators.pattern('^[a-zA-Z]{6,15}')])
    });
  }
  onsubmit(){
    console.log('under submit', this.reset.value);
    this.userService.prerequest(this.reset.value).subscribe((data: any) => {
      console.log(data.result);
      console.log(localStorage.getItem('dataSource'));
    });
  }
}
