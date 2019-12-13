import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  
  
  constructor(private http: HttpClient) { }
  link = 'https://localhost:44366/api/Account';

  postrequest(user) {
    console.log("user",user.firstName);
    
    const body = {
      "FirstName": user.firstName,
      "LastName":  user.lastName,
      "Emailid":   user.email,
      "Password":  user.password,
    }
    console.log('test', user.firstName);
    console.log('test', user.email);
    return this.http.post(this.link + '/add', body);
  }
  postRequest(login) {
    const body ={
      "Emailid": login.email,
      "Password": login.password,
    }
    return this.http.post(this.link + '/login', body);
  }
  PostRequest(forget){
    const body ={
      "Emailid": forget.email,
    }
    return this.http.post(this.link + '/ForgetPassword',body);
  }
  prerequest(reset){
    const body ={
      "Emailid": reset.email,
      "Password": reset.password,
      "Confirm Password":reset.confirmpassword,
    }
    return this.http.put(this.link + '/ResetPassword',body);
  }
  google(email) {
  const body = {
    "Emailid": email
  }
  return this.http.post(this.link + '/google', body);
  }
  fb(email) {
    const body = {
      "Emailid": email
    }
    return this.http.post(this.link + '/fb', body);
    }
   get(token){
     return this.http.get(this.link + '/jwt', { headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
   }
   getProfilepic(token, formdata) {
    return this.http.post(this.link +'/profilepic',formdata, { headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) })
  }
  Search(token,Title) {
   return this.http.get(this.link + '/searchlist',{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
}

