import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { HeaderComponent } from './components/header/header.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, HomeComponent, HeaderComponent],
  template: `
    <app-header />
    <main>
      <app-home />
    </main>
  `,
  styles: [
    `main {
      padding: 16px;
      width: 100%;
      align-items: center;
      justify-items: center;
      text-align: center;
      align-content: center;
    }`
  ],
})
export class AppComponent {
  title = 'gym-notes-front';
}
