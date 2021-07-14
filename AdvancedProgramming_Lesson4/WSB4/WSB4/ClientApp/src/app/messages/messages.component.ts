import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-messages',
  templateUrl: './messages.component.html',
  styleUrls: ['./messages.component.css']
})
export class MessagesComponent implements OnInit {
  backendResponse: string;

  constructor(private http: HttpClient) { }

  ngOnInit() {
  }
  sendRequestToBackend() {
    this.http.get("https://localhost:44333/" + "messages" + "/getMessage").subscribe(response => { this.backendResponse = response.toString(); },
      error => { this.backendResponse = error; });

  }

}
