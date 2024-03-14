import { Component, OnInit, OnDestroy } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Subscription } from 'rxjs';
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
export class AppComponent implements OnInit, OnDestroy {
  title = 'client';

  private recipeSubscription?: Subscription;

  constructor(private recipeService: RecipeService) {}

  ngOnInit(): void {
    this.getRecipe();
  }

  ngOnDestroy(): void {
    this.recipeSubscription?.unsubscribe();
  }

  getRecipe(): void {
    this.recipeSubscription = this.recipeService
      .getRecipe()
      .subscribe((response) => {
        console.log(response);
      });
  }
}
