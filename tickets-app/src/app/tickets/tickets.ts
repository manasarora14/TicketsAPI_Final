import { Component } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { TicketService } from '../services/ticket';

@Component({
  selector: 'app-tickets',
  standalone: true,
  imports: [CommonModule, DatePipe],
  templateUrl: './tickets.html',
  styleUrls: ['./tickets.css']
})
export class TicketsComponent {
  tickets: any[] = [];

  constructor(private service: TicketService) {
    this.service.getTickets().subscribe(res => {
      this.tickets = res;
    });
  }
}
