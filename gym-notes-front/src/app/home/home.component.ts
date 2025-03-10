import { Component } from '@angular/core';
import { ExcercisesComponent } from '../components/excercises/excercises.component';

@Component({
  selector: 'app-home',
  imports: [ExcercisesComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {

}
