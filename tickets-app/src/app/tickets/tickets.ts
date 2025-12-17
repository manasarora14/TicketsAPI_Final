import { Component } from '@angular/core';
import { CommonModule, DatePipe, NgFor } from '@angular/common';
import { TicketService } from '../services/ticket';

@Component({
  selector: 'app-tickets',
  standalone: true,
  imports: [CommonModule, NgFor, DatePipe],
  templateUrl: './tickets.html'
})
export class TicketsComponent {

  tickets: any[] = [];

  constructor(private service: TicketService) {
    this.service.getTickets().subscribe({
      next: (res) => {
        console.log('API RESPONSE:', res);
        this.tickets = res;
      },
      error: (err) => console.error(err)
    });
  }
}
