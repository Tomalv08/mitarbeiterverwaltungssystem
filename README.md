# IPT6.1 Projekt: Mitarbeiterverwaltungssoftware

## Inhaltsverzeichnis
1. Grundlegende Informationen
2. Arbeitsjournal
3. Projektidee
4. Projektbeschrieb
5. Projektplanung
6. Architektur und Design
7. Prototyping
8. Implementation
9. Testing
10. Projektpräsentation
11. Fazit

## Arbeitsjournal

### Woche 1
- Einführung in das Projekt und initiale Planung.
- Besprechung der Projektidee und erste Konzeptskizzen.

### Woche 2
- Erstellung erster Prototypen mit Blazor.
- Diskussion der Datenbankanforderungen.

### Woche 3
- Beginn der Implementierung der Benutzeroberfläche.
- Erste Probleme mit SQLite erkannt und dokumentiert.

### Woche 4
- Weiterentwicklung der Benutzeroberfläche.
- Erneute Versuche, SQLite zu integrieren.

### Woche 5
- Alternative Datenbanklösungen recherchiert.
- Entscheidung, bei SQLite zu bleiben und weitere Problemlösungen zu suchen.

### Woche 6
- Verbesserung der Frontend-Designs mit Bootstrap (blau/weiß).
- Weitere Tests und Debugging von SQLite.

### Woche 7
- Erfolgslose Implementierungsversuche der Datenbank.

### Woche 8
- Zusammenarbeit mit Lehrkräften zur Problemlösung.
- Weitere Fehlerbehebungen und Tests.

### Woche 9
- Neuanfang des Projekts aufgrund anhaltender Datenbankprobleme.
- Planung einer neuen Implementierungsstrategie.

### Woche 10
- Wiederaufnahme der Arbeit an der Benutzeroberfläche.
- Diskussion möglicher Änderungen an der Datenbankstruktur.

### Woche 11
- Anpassungen und Verbesserungen am User Interface.
- Vorbereitung auf neue Datenbanktests.

### Woche 12
- Zweiter Neuanfang nach weiteren Problemen mit SQLite.

### Woche 13
- Fortschritte bei der Benutzerverwaltung.

### Woche 14
- Problembehebung SQLite

### Woche 15
- Problembehebung SQLite

### Woche 16
- Problembehebung SQLite

### Woche 17
- Problembehebung SQLite
- Versagen mit SQLite
- Abgabe

## Projektidee

Unsere Projektidee war es, eine Mitarbeiterverwaltungssoftware zu entwickeln. Die Software sollte es ermöglichen, Mitarbeiter zu erfassen, anzuzeigen und zu entfernen. Die Hauptfunktionalitäten sollten die Erstellung, Anzeige, Bearbeitung und Löschung von Mitarbeiterdatensätzen umfassen. Ziel war es, eine benutzerfreundliche Oberfläche zu schaffen, die mit modernen Webtechnologien umgesetzt wird.

## Projektbeschrieb

Die Mitarbeiterverwaltungssoftware wurde mit dem Blazor Framework und C# entwickelt. Blazor ermöglicht die Erstellung von interaktiven Web-UI's unter Verwendung von C# anstelle von JavaScript. Für die Datenhaltung haben wir SQLite als Datenbanklösung gewählt. Trotz zahlreicher Versuche, SQLite zu integrieren, haben wir aufgrund andauernder technischer Probleme schließlich versagt.

## Projektplanung

Die Projektplanung erfolgte in mehreren Phasen:
1. **Ideenfindung und Konzeption:** Besprechung und Skizzierung der Projektidee.
2. **Prototyping:** Erstellung erster UI-Prototypen und Datenbankkonzepte.
3. **Implementierung:** Entwicklung der Anwendung in iterativen Schritten.
4. **Testing:** Umfassende Tests zur Sicherstellung der Funktionalität.

## Architektur und Design

Das Design der Software basiert auf dem Blazor Framework und verwendet Bootstrap zur Gestaltung der Benutzeroberfläche. Die Farbgebung der UI ist hauptsächlich in Blau und Weiß gehalten, um ein professionelles und klares Erscheinungsbild zu gewährleisten.

## Prototyping

Im Prototyping haben wir erste Entwürfe der Benutzeroberfläche erstellt und grundlegende Funktionalitäten getestet. Dies half uns, frühzeitig Designentscheidungen zu treffen und Feedback zu sammeln.

## Implementation

Die Implementierung erfolgte in mehreren Schritten:
- Aufbau der Blazor-Komponenten für die UI.
- (Implementierung der CRUD-Funktionalitäten.)
- Integration und Test der Datenbankanbindung.
- Anpassung und Feinschliff der Benutzeroberfläche.

## Testing

Das Testing umfasste Unit-Tests für die Geschäftslogik sowie Integrationstests für die gesamte Anwendung. Aufgrund der Probleme mit SQLite mussten wir umfangreiche Tests durchführen, um alternative Lösungen zu finden und zu implementieren.

## Auflistung der Datentypen und Pflichtfelder

### Employee

- **Id**: `int` (Pflichtfeld)
- **Name**: `string` (Pflichtfeld)
- **Position**: `string` (Pflichtfeld)
- **Department**: `string` (optional, nur für Manager)
- **Manager**: `Manager` (optional, Referenz auf einen Manager)

### Manager (erbt von Employee)

- **Id**: `int` (Pflichtfeld)
- **Name**: `string` (Pflichtfeld)
- **Position**: `string` (Pflichtfeld)
- **Department**: `string` (Pflichtfeld)
- **Employees**: `List<Employee>` (optional, Liste von Mitarbeitern, die dem Manager zugeordnet sind)
