import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TesteService, Post } from './services/teste.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {
  posts: Post[] = [];

  constructor(private testeService: TesteService) {}

  ngOnInit(): void {
    this.testeService.getPosts().subscribe({
      next: (data: Post[]) => {
        this.posts = data;
      },
      error: (err: unknown) => {
        console.error('Erro ao buscar posts:', err);
      }
    });
  }
}
