# FreeStyleApp
This is the project only Apis services that i build to learn how backend work


docker run -d \
  --name freestyle_db \
  -e POSTGRES_USER=postgres \
  -e POSTGRES_PASSWORD=123456 \
  -e POSTGRES_DB=free_style_app \
  -p 5555:5432 \
  postgres:16