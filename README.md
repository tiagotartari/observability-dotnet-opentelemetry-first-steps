# Observability in .NET Applications with OpenTelemetry

This project demonstrates how to implement observability in .NET applications using OpenTelemetry. It includes configurations for integrating OpenTelemetry with Prometheus, Grafana, and Jaeger to provide comprehensive monitoring and tracing capabilities.

## Overview

The repository contains a step-by-step guide and necessary configurations to set up:

- OpenTelemetry Collector for collecting and exporting telemetry data.
- Prometheus for metrics storage and monitoring.
- Grafana for data visualization.
- Jaeger for distributed tracing.


## Getting Started

1.  **Clone the repository:**
    
    bash
    
    Copiar código
    
    `git clone https://github.com/tiagotartari/observability-dotnet-opentelemetry-first-steps.git
    cd observability-dotnet-opentelemetry` 
    
2.  **Run the services:**
    
    bash
    
    Copiar código
    
    `docker-compose up -d` 
    
3.  **Access the services:**
    
    -   Prometheus: `http://localhost:9090`
    -   Grafana: `http://localhost:3000` (default login: `admin/admin`)
    -   Jaeger: `http://localhost:16686`

## Configuration Files

-   **docker-compose.yaml:** Defines the services and their configurations.
-   **otelcol-contrib/config.yaml:** Configures the OpenTelemetry Collector.
-   **prometheus/prometheus.yml:** Configures Prometheus scraping.

## Insights

1.  **Comprehensive Application Visibility:** Implementing observability with OpenTelemetry in .NET applications provides a complete view of the service's performance and stability. Real-time monitoring of metrics, traces, and logs allows for rapid identification and resolution of anomalies and bottlenecks.
    
2.  **Seamless Integration with Monitoring Tools:** OpenTelemetry simplifies integration with popular monitoring tools like Prometheus and Grafana. Prometheus handles metric storage and processing, while Grafana offers interactive and customizable dashboards for effective data visualization.
    
3.  **Enhanced User Experience and Reliability:** By reducing mean time to detection (MTTD) and mean time to resolution (MTTR), implementing observability with OpenTelemetry not only improves the user experience but also significantly lowers the risks of downtime and associated penalties. This enhances overall service reliability and customer satisfaction.
    

## Learn More

For a detailed explanation and step-by-step guide, read the full article [here](https://tiagotartari.net/observabilidade-em-aplicacoes-dotnet-com-opentelemetry.html).

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.
