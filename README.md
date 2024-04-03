# window-backend

This project creates a webpage where users can draw a rectangle SVG figure, resize it using the mouse, and display its perimeter. The initial dimensions of the SVG figure are taken from a JSON file, and after resizing, the system updates the JSON file with the new dimensions. The frontend is implemented using Angular, and the backend for JSON saving is implemented in C# through an API.
 
## Deployment

#### To deploy this project run

```bash
  dotnet run --launch-profile window-backend
```


## API Reference

#### Get Window

```http
  GET /api/Window
```
#### Update Window

```http
  POST /api/Window
```