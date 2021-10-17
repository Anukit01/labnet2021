import { Injectable } from '@angular/core';



@Injectable({
  providedIn: 'root',
})
export class MessageService {
  messages: string[] = ["Oh, no. Something went wrong :´("];

  add(message: string) {
    this.messages.push(message);
  }

  clear() {
    this.messages = [];
  }
}
