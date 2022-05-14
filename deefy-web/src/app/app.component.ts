import { Component } from '@angular/core';
import { LoginService } from './services/login/login.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'deefy-web';

  constructor(private loginService: LoginService){
    
  }

  sair(){
    this.loginService.sair();
  }


}
