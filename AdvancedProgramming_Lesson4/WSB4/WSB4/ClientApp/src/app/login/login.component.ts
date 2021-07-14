import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  userLoginDTO = new UserLoginDTO();

  constructor(private http: HttpClient, private router: Router) { }

  ngOnInit() {
  }

  sendRequestToBackend() {
    this.http.post("https://localhost:44351/" + "account" + "/login", this.userLoginDTO).subscribe(response => {
      this.router.navigate(['/test']);
    },
      error => {

      });
  }
}
