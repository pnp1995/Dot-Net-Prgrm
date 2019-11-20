import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-service-card',
  templateUrl: './service-card.component.html',
  styleUrls: ['./service-card.component.scss']
})
export class ServiceCardComponent implements OnInit {
select =true;
card1 = true;
card2 = true;
button ="ADD TO CART";
  @Output() messageEvent = new EventEmitter<string>();
  constructor() { }
 
  ngOnInit() {
  }
  Advance(){
    this.card1 = false;
    this.select =false;
   this.button ="SELECTED";
   this.messageEvent.emit('Advance');
  }
  Basic(){
    this.card2  = false;
    this.select =false;
   this.button ="SELECTED";
   this.messageEvent.emit('Basic');
  }
}
