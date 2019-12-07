import { Injectable } from '@angular/core';
import { BehaviorSubject, Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  private messageSource = new BehaviorSubject('default message');
  currentMessage = this.messageSource.asObservable();

  private _dashboard = new Subject<Boolean>();
  dash$ = this._dashboard.asObservable();

  private messageSources = new BehaviorSubject(true);
  currentMessages = this.messageSources.asObservable();

  constructor() { }
  

//  viewlist(value :boolean){
//   this._dashboard.next(value);
// }

 changeMessage(message: string) {
   console.log(message,"dataservice");
   
   this.messageSource.next(message)
 }


 changeMessages(current:boolean){
   this.messageSources.next(current);
   }
}
