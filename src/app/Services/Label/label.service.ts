import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LabelService {
 
  constructor(private http:HttpClient) { }
  link = 'https://localhost:44366/api/label';
  createLabel(label,token){
    const body ={
      label : label,
      token : token
    };
    return this.http.post(this.link +'/add',body, { headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) } );
  }
  GetRequest(token) {
    return this.http.get(this.link + '/list', { headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  deleteLabel(id,token) {
    return this.http.delete(this.link + '/delete',{headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
}
