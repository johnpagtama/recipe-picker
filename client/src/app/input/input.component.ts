import { Component, Input } from '@angular/core';
import { NgClass } from '@angular/common';

@Component({
  selector: 'app-input',
  standalone: true,
  imports: [NgClass],
  templateUrl: './input.component.html',
  styleUrl: './input.component.css',
})
export class InputComponent {
  @Input() type: string = 'text';
  @Input() placeholder: string = 'Text';
  @Input() name: string = 'input';
  @Input() class: string = '';
}
