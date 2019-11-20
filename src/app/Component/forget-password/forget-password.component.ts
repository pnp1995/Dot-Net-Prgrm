import { UserService } from 'src/app/Services/UserServices/user.service';
import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormControl, NgForm, RequiredValidator } from '@angular/forms';

@Component({
  selector: 'app-forget-password',
  templateUrl: './forget-password.component.html',
  styleUrls: ['./forget-password.component.scss']
})
export class ForgetPasswordComponent implements OnInit {
  forget: FormGroup;
  form:NgForm;
  constructor(private userService:UserService) { }

  ngOnInit() {
    this.forget = new FormGroup({
      email: new FormControl('',[Validators.required,Validators.email]),
    })
  }
  onsubmit(){
    console.log('under submit', this.forget.value);
    this.userService.PostRequest(this.forget.value).subscribe((data: any) => {
      console.log(data.result);
    });
  }
}
