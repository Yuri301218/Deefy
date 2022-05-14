import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserComponent } from './user/user.component';
import { HomeComponent } from './home/home.component';
import { EditarUsuarioComponent } from './editar-usuario/editar-usuario.component';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { LoginComponent } from './login/login.component';
import { ArtistaComponent } from './artista/artista.component';
import { EditarArtistaComponent } from './editar-artista/editar-artista.component';

@NgModule({
  declarations: [
    AppComponent,
    UserComponent,
    HomeComponent,
    EditarUsuarioComponent,
    LoginComponent,
    ArtistaComponent,
    EditarArtistaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
