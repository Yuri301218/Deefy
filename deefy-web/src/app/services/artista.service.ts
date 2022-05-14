import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Artista } from './model/artista';

@Injectable({
  providedIn: 'root'
})
export class ArtistaService extends ApiService {

  constructor(http: HttpClient) {
    super(http);
  }

  buscarArtistas(){
    return this.get<Artista[]>(this.url + "Artista");
  }

  buscarArtista(id: number){
    return this.get<Artista>(this.url + "Artista/" + id);
  }

  atualizarArtista(Artista: Artista){
    return this.put(this.url + "Artista/" + Artista.id, Artista);
  }

  criarArtista(Artista: Artista){
    return this.post(this.url + "Artista", Artista);
  }

  excluirArtista(id: number){
    return this.delete(this.url + "Artista/" + id);
  }
 
}
