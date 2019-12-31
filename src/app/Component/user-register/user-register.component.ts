import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormControl, NgForm } from '@angular/forms';
import { UserService } from 'src/app/Services/UserServices/user.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-user-register',
  templateUrl: './user-register.component.html',
  styleUrls: ['./user-register.component.scss']
})
export class UserRegisterComponent implements OnInit {
  register: FormGroup;
  registerForm: any;
  form: NgForm;
 // cardType;
  constructor(public userService: UserService, private router: Router) { }
  ngOnInit() {
    this.register = new FormGroup({
      firstName: new FormControl('', [Validators.pattern('^[a-zA-Z]{4,15}'), Validators.required]),
      lastName: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{4,15}')]),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{6,15}')]),
      confirmPassword: new FormControl('', [Validators.required])
    });
  }
  onSubmit() {
    console.log('under submit', this.register.value);
    this.userService.postrequest(this.register.value).subscribe((data: any) => {
      console.log(data);
    });
  }
  onlogin() {

    this.router.navigate(['login'])
  }
  // receiveMessage($event) {
  //   this.cardType = $event
  // }

}
