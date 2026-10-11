# Practical 7 – Feedback Management Module

**Aim:** Develop Feedback Management Module using MVC Layout, Partial View & Validation (HTML Helpers, Validation, Layouts).

## Requirements
- Visual Studio 2026 or compatible Visual Studio
- .NET 8 SDK

## Run
1. Open `Practical_7_Feedback_Management.csproj` in Visual Studio.
2. Restore dependencies if prompted.
3. Set the project as startup project and press F5.
4. Open the local URL displayed by Visual Studio. The default route opens `Feedback/Index`.

## Concepts demonstrated
- MVC: `FeedbackController`, `Feedback` model and Razor views.
- Shared layout: `Views/Shared/_Layout.cshtml`.
- Partial view: `Views/Shared/_FeedbackForm.cshtml`.
- HTML Helpers: `TextBoxFor`, `DropDownListFor`, and `TextAreaFor`.
- Data Annotation and server-side validation through `ModelState.IsValid`.
- Client-side unobtrusive validation.
- Routing to `Feedback/Index`.

## Note
Feedback is kept in an in-memory list for demonstration and is cleared when the application restarts. Client-side validation libraries load from a CDN and require internet access; server-side validation still works without it. `Output_sample.png` is an illustrative mock-up, not an actual screenshot from a running app. Replace it with your own browser screenshot if required.
