import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AdminService {
 

  constructor(private http: HttpClient) { }
  link = 'https://localhost:44366/api/Admin';

  addAdmin(user) {
    console.log("user",user.firstName);
    
    const body = {
      "FirstName": user.firstName,
      "LastName":  user.lastName,
      "Email": user.email,
      "Password": user.password,
    }
    console.log("this is final message", body);
    return this.http.post(this.link + '/add', body);
    
    
  }



}
