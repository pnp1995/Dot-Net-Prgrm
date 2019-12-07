import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CollaboratorService {


  constructor(private http: HttpClient) { }
  link = 'https://localhost:44366/api/collaborator';
  addCollab(sender, id, receiver) {
    const body = {
      "SenderEmail": sender,
      "Noteid": id,
      "ReceiverEmail": receiver
    };
    return this.http.post(this.link + '/add', body);
  }
  getCollaborator(id: any) {
    return this.http.get(this.link + '/list?Noteid=' + id);
  }
    removeCollaborator(id) {
      
  return this.http.delete(this.link +'/delete?Id='+ id);
    }

// GetRequest(token) {
//   return this.http.get(this.link + '/add', { headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
// }
}