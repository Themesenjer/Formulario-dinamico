import { Component } from '@angular/core';
import { ProductFormComponent } from './product-form/product-form.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ProductFormComponent], // Agregar aquí
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'dynamic-form';
}
