import { Component, inject } from '@angular/core'
import { MatButtonModule } from '@angular/material/button'
import { MatDividerModule } from '@angular/material/divider'
import { MatIconModule } from '@angular/material/icon'
import { MatMenuModule } from '@angular/material/menu'
import { MatToolbarModule } from '@angular/material/toolbar'
import { SessionPanelComponent } from '../session-panel/session-panel.component'
import { NotificationsPanelComponent } from '../notifications-panel/notifications-panel.component'
import { ThemeSelectorComponent } from '../theme-selector/theme-selector.component'
import { SessionService } from '@fwks/services'
import { Title } from '@angular/platform-browser'
import { RouterLink } from '@angular/router'

@Component({
    selector: 'fwks-nav-top',
    standalone: true,
    imports: [
        MatToolbarModule,
        MatMenuModule,
        MatIconModule,
        MatButtonModule,
        MatDividerModule,
        SessionPanelComponent,
        NotificationsPanelComponent,
        ThemeSelectorComponent,
        RouterLink
    ],
    templateUrl: './nav-top.component.html',
    styles: ''
})
export class NavTopComponent {

    session = inject(SessionService)
    title = inject(Title).getTitle()
}
