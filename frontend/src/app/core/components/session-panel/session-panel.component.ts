import { Component, inject } from '@angular/core'
import { MatButtonModule } from '@angular/material/button'
import { MatDividerModule } from '@angular/material/divider'
import { MatMenuModule } from '@angular/material/menu'
import { SessionService } from '@fwks/services'

@Component({
    selector: 'fwks-session-panel',
    standalone: true,
    imports: [
        MatMenuModule,
        MatDividerModule,
        MatButtonModule,
    ],
    templateUrl: './session-panel.component.html',
    styles: ''
})
export class SessionPanelComponent {
    session = inject(SessionService)
}
