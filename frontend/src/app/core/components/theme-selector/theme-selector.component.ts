import { Component } from '@angular/core'
import { MatButtonModule } from '@angular/material/button'
import { MatIconModule } from '@angular/material/icon'

@Component({
    selector: 'fwks-theme-selector',
    standalone: true,
    imports: [
        MatIconModule,
        MatButtonModule,
    ],
    template: `
        <button (click)="toggle()" mat-icon-button type="button">
            <mat-icon>
                @if (light) {
                    dark_mode
                } @else {
                    light_mode
                }
            </mat-icon>
        </button>
    `,
    styles: ''
})
export class ThemeSelectorComponent {

    light!: boolean
    body = document.querySelector('body')!

    constructor() {
        this.load()
    }

    load(): void {
        const current = localStorage.getItem('fwks_app_theme') ?? 'light'
        this.light = current === 'light'
        this.body.classList.add(current)
    }

    toggle(): void {
        this.light = !this.light
        this.body.classList.add(this.light ? 'light' : 'dark')
        this.body.classList.remove(this.light ? 'dark' : 'light')
        localStorage.setItem('fwks_app_theme', this.light ? 'light' : 'dark')
    }
}
