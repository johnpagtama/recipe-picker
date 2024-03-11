import { Component, Input } from '@angular/core';
import { NgClass } from '@angular/common';

@Component({
  selector: 'app-button',
  standalone: true,
  imports: [NgClass],
  templateUrl: './button.component.html',
  styleUrl: './button.component.css',
})
export class ButtonComponent {
  @Input() type: string = 'button';
  @Input() text: string = 'Button';
  @Input() name: string = 'button';
  @Input() class: string = '';

  onClick(event: MouseEvent) {
    event.preventDefault();
    console.log(
      `MouseEvent: ${event.type}\nType: ${this.type}\nText: ${this.text}\nName: ${this.name}\nClass: ${this.class}`
    );
  }
}
