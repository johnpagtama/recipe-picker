import { Component, OnInit, OnDestroy } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { RecipeService } from './recipe.service';
import { ButtonComponent } from './button/button.component';
import { InputComponent } from './input/input.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ButtonComponent, InputComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent implements OnInit {
  title = 'client';

  constructor(private recipeService: RecipeService) {}

  ngOnInit(): void {
    this.getRecipe();
  }

  getRecipe(): void {
    this.recipeService.getRecipe().subscribe((response) => {
      console.log(response);
    });
  }
}
