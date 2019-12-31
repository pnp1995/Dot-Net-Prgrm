import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
@Injectable({
  providedIn: 'root'
})
export class NotesServiceService {

  constructor(private http: HttpClient) { }
  link = 'https://localhost:44366/api/notes';
  Postrequest(data, token) {
    const body = {
      "Title": data.Title,
      "Descriiption": data.Descriiption
    }
    return this.http.post(this.link + '/add', body, { headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  GetRequest(token) {
    return this.http.get(this.link + '/list', { headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  putrequest(id, date) {
    console.log(date);
    return this.http.put(this.link + '/reminder?Reminder=' + date + '&Id=' + id, null);
  }
  removeReminder(id, date) {
   console.log(date);
   return this.http.post(this.link + '/removereminder?Reminder=' + date + '&Id=' + id, null);  
  }
  GetArchive(id) {
    return this.http.put(this.link + '/archive?Id=' + id, null);
  }
  UnArchive(id) {
    return this.http.put(this.link + '/unarchive?Id=' + id, null);
  }
  GetAllArchive(token) {
    return this.http.get(this.link + '/archivelist', { headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  Getcolor(id, Colour,token) {
    const data=
    {
      Id:id,
      Colour:Colour
    }
    return this.http.post(this.link + '/colour', data ,{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) });
  }
  Delete(id) {
    return this.http.put(this.link + '/delete?Id=' + id, null);
  }
  addTrash?(id) {
    return this.http.post(this.link + '/trash?Id=' + id, null);
  }
  GetAllTrash(token) {
   return this.http.get(this.link + '/trashlist' ,{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) } )
  }
  restore(id) {
   return this.http.get(this.link + '/restore?Id=' + id);
  }
  restoreAll(token) {
    return this.http.get(this.link + '/restoreall' ,{ headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) } )
  }

  update(body) {
    console.log("body in service-->",body);    
    const token = JSON.parse(localStorage.getItem('token'));
    console.log("token-->",token);       
    return this.http.put(this.link + '/update', body, { headers: new HttpHeaders().set('Authorization', 'Bearer ' + token.result) });
  }
  getImage(formData,id) {
   return this.http.post(this.link +'/imageupload',formData);
  }

  pinNote(id) {
    return this.http.post(this.link + '/pin?Id=' +id, null)

  }
  unPinNote(id) {
    return this.http.post(this.link + '/unpin?Id=' +id,null)
   }
    




  // displayNotes(token) {
  //   return this.http.get(this.link + '/list', { headers: new HttpHeaders().set('Authorization', 'Bearer ' + token) })
  // }
}
