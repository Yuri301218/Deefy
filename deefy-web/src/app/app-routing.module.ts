import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ArtistaComponent } from './artista/artista.component';
import { AuthGuardService } from './auth-guard.service';
import { EditarArtistaComponent } from './editar-artista/editar-artista.component';
import { EditarUsuarioComponent } from './editar-usuario/editar-usuario.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { UserComponent } from './user/user.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'login',
    pathMatch: 'full'
  },
  { path: 'home', component: HomeComponent, canActivate: [AuthGuardService] },
  { path: 'login', component: LoginComponent },
  { path: 'user', component: UserComponent, canActivate: [AuthGuardService]  },
  { path: 'artista', component: ArtistaComponent, canActivate: [AuthGuardService]  },
  { path: 'editar-usuario', component: EditarUsuarioComponent, canActivate: [AuthGuardService] },
  { path: 'editar-artista', component: EditarArtistaComponent, canActivate: [AuthGuardService] }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
