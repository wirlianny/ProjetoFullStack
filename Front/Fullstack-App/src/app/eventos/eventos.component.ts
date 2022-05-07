
import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { ToastrService } from 'ngx-toastr';
import { Evento } from '../models/Evento';
import { EventoService } from '../services/evento.service';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {
  modalRef!: BsModalRef;
  public eventos: Evento[] = [];
  public eventosFiltrados: Evento[] = [];

  public widthImg = 150;
  public marginImg = 2;
  public showImg = true;
  private filterListed = '';


  public get filterList(): string{
    return this.filterListed;
  }

  public set filterList(value: string){
    this.filterListed = value;
    this.eventosFiltrados = this.filterList ? this.filterEvents(this.filterList) : this.eventos;
  }

  public filterEvents(filtrarPor: string): Evento[]{
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      (evento: { tema: string; local: string; }) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
      evento.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
  }


  constructor(private eventoService: EventoService,
    private modalService: BsModalService,
    private toastr: ToastrService
    ) { }

  public ngOnInit(): void {
    this.getEventos();
  }

  public changeImage(): void{
    this.showImg = !this.showImg;
  }

  public getEventos(): void {
    this.eventoService.getEventos().subscribe(
      (eventos: Evento[]) => {
        this.eventos = eventos;
        this.eventosFiltrados = this.eventos;
      },
      error => console.log(error)
    );
  }

  openModal(template: TemplateRef<any>): void {
    this.modalRef = this.modalService.show(template, {class: 'modal-sm'});
  }

  confirm(): void {
    this.modalRef.hide();
  }

  decline(): void {
    this.modalRef.hide();
  }

}
