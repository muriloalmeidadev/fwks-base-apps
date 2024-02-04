import { Component, inject } from '@angular/core'
import { MatButtonModule } from '@angular/material/button'
import { Title } from '@angular/platform-browser'
import { RouterOutlet } from '@angular/router'
import { NavTopComponent } from '@fwks/components'
import { SessionService } from '@fwks/services'

@Component({
    selector: 'fwks-root',
    standalone: true,
    imports: [
        RouterOutlet,
        NavTopComponent,
        MatButtonModule,
    ],
    templateUrl: './app.component.html',
    styles: [],
})
export class AppComponent {
    session = inject(SessionService)
    title = 'fwks @ base app'

    _ = inject(Title).setTitle(this.title)
}
