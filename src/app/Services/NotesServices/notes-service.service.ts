import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
@Injectable({
  providedIn: 'root'
})
export class NotesServiceService {
 
  constructor(private http: HttpClient) { }
  link = 'https://localhost:44366/api/notes';
  Postrequest(notes, token) {
    const body = {
      "Title": notes.title,
      "Descriiption": notes.description
    }
    return this.http.post(this.link + '/add', body, { headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  GetRequest(token) {
    return this.http.get(this.link + '/list', { headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  putrequest(id, date, token) { 
    return this.http.put(this.link + '/reminder?Reminder='+date+'&Id='+id, null);
  }
  GetArchive(id) {
   return this.http.put(this.link + '/archive?Id='+id,null);
  }
  Getcolor(id,Colour){
    return this.http.post(this.link +'/colour?Colour='+Colour+'&Id='+id, null);
  }
  Delete(id) {
    return this.http.put(this.link+ '/delete?Id=' +id,null);
  }
  addTrash?(id) {  
  return this.http.post(this.link + '/trash?Id=' +id,null);
  }

}
