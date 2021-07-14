import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  userRegisterDTO = new UserRegisterDTO();

  constructor(private http: HttpClient, private router: Router) { }

  ngOnInit() {
  }

  sendRequestToBackend() {
    this.http.post("https://localhost:44351/" + "account" + "/register", this.userRegisterDTO).subscribe(response => {
      this.router.navigate(['/login']);
    },
      error => {

      });
  }
}
