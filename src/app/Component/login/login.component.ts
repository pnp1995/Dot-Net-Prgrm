import { UserService } from 'src/app/Services/UserServices/user.service';
import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormControl, NgForm } from '@angular/forms';
import { from } from 'rxjs';
import { AuthService } from 'angular-6-social-login';
import { GoogleLoginProvider, FacebookLoginProvider } from 'angular-6-social-login';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  login: FormGroup;
  form: NgForm;
  router: any;
  sub: any;
  user;
  constructor(private userService: UserService, private auth: AuthService) { }

  ngOnInit() {
    this.login = new FormGroup({
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.pattern('^[a-zA-Z]{6,15}')]),
    });

  }
  onlogin() {
    console.log('under submit', this.login.value);
    this.userService.postRequest(this.login.value).subscribe((data: any) => {
      console.log(data.result);
    });
  }
  // googlelogin() {
  //   this.sub = this.auth.signIn("google").subscribe((data: any) => {
  //     console.log(data);
  //     this.user = data; return this.router.navigateByUrl('/dash');
  //   });
  // }

  googlelogin(): void {
    this.auth.signIn(GoogleLoginProvider.PROVIDER_ID);
  }
 
  fblogin(): void {
    this.auth.signIn(FacebookLoginProvider.PROVIDER_ID);
  } 
}
