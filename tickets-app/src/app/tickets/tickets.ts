import { Component, OnInit } from '@angular/core';
import { CommonModule, DatePipe, NgFor } from '@angular/common';
import { TicketService } from '../services/ticket';

@Component({
  selector: 'app-tickets',
  standalone: true,
  imports: [CommonModule, NgFor, DatePipe],
  templateUrl: './tickets.html'
})
export class TicketsComponent implements OnInit {

  tickets: any[] = [];

  constructor(private service: TicketService) {}

  ngOnInit(): void {
    this.loadTickets();
  }

  loadTickets(): void {
    this.service.getTickets().subscribe({
      next: (res) => {
        console.log('API RESPONSE:', res);
        this.tickets = res;
      },
      error: (err) => console.error('API ERROR:', err)
    });
  }
}
