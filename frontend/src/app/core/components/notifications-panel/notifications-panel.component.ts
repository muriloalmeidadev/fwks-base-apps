import { Component, inject } from '@angular/core'
import { MatBadgeModule } from '@angular/material/badge'
import { MatButtonModule } from '@angular/material/button'
import { MatIconModule } from '@angular/material/icon'
import { MatMenuModule } from '@angular/material/menu'
import { SessionService } from '@fwks/services'

@Component({
    selector: 'fwks-notifications-panel',
    standalone: true,
    imports: [
        MatButtonModule,
        MatBadgeModule,
        MatIconModule,
        MatMenuModule,
    ],
    templateUrl: './notifications-panel.component.html',
    styles: '',
})
export class NotificationsPanelComponent {
    session = inject(SessionService)

}

export interface Notification {
    title: string

}